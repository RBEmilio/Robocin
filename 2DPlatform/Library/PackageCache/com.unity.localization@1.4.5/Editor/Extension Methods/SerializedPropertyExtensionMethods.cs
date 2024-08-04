using UnityEditor.AddressableAssets.GUI;
using UnityEngine;

namespace UnityEditor.Localization
{
    static class SerializedPropertyExtensionMethods
    {
        public static TObject GetActualObjectForSerializedProperty<TObject>(this SerializedProperty property, System.Reflection.FieldInfo field)
        {
            string unused = "";
            return SerializedPropertyExtensions.GetActualObjectForSerializedProperty<TObject>(property, field, ref unused);
        }

        public static SerializedProperty AddArrayElement(this SerializedProperty property)
        {
            property.InsertArrayElementAtIndex(property.arraySize);
            return property.GetArrayElementAtIndex(property.arraySize - 1);
        }

        public static SerializedProperty InsertArrayElement(this SerializedProperty property, int index)
        {
            property.InsertArrayElementAtIndex(index);
            return property.GetArrayElementAtIndex(index);
        }

        public static string GetValueAsString(this SerializedProperty property)
        {
            Debug.Assert(property.propertyType != SerializedPropertyType.ObjectReference);

            switch (property.type)
            {
                case "ArraySize":
                case "int":
                case "byte":
                case "sbyte":
                case "short":
                case "ushort":
                case "Enum":
                    return property.intValue.ToString();

                case "long":
                case "ulong":
                    return property.longValue.ToString();

                case "float":
                    return property.floatValue.ToString();

                case "double":
                    return property.doubleValue.ToString();

                case "string":
                    return property.stringValue;

                case "bool":
                    return property.boolValue == true ? "1" : "0";
                default:
                    return string.Empty;
            }
        }

        public static void ApplyPropertyModification(this SerializedProperty property, PropertyModification modification)
        {
            if (property.propertyType == SerializedPropertyType.ObjectReference)
            {
                property.objectReferenceValue = modification.objectReference;
                return;
            }

            switch (property.type)
            {
                case "ArraySize":
                case "int":
                case "byte":
                case "sbyte":
                case "short":
                case "ushort":
                case "Enum":
                    property.intValue = int.Parse(modification.value);
                    break;

                case "long":
                case "ulong":
                    property.longValue = long.Parse(modification.value);
                    break;

                case "float":
                    property.floatValue = float.Parse(modification.value);
                    break;

                case "double":
                    property.doubleValue = double.Parse(modification.value);
                    break;

                case "string":
                    property.stringValue = modification.value;
                    break;

                case "bool":
                    property.boolValue = modification.value == "1";
                    break;
            }
        }
    }
}

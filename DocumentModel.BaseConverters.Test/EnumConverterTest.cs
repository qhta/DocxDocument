using DMW = DocumentModel.Wordprocessing.Test;

namespace DocumentModel.BaseConverters.Test;

/// <summary>
///   Provides unit tests for verifying the correctness of <see cref="EnumOpenXmlConverter"/> conversions between .NET enum values and Open XML enum types.
///   Tests round-trip conversion, strongly-typed helpers, and Open XML element creation for enum values.
/// </summary>
public static class EnumConverterTest
{
    /// <summary>
    ///   Runs all EnumOpenXmlConverter tests and reports results to the console.
    /// </summary>
    /// <returns>True if all tests pass; otherwise, false.</returns>
    public static bool Run()
    {
        bool testResult = true;
        Console.Write("EnumOpenXmlConverterTest TestEnumValueConversion ");
        if (TestEnumValueConversion())
        {
            Console.WriteLine("passed.");
        }
        else
        {
            Console.WriteLine("failed.");
            testResult = false;
        }
        Console.Write("EnumOpenXmlConverterTest TestEnumTypeConversion ");
        if (TestEnumTypeConversion())
        {
            Console.WriteLine("passed.");
        }
        else
        {
            Console.WriteLine("failed.");
            testResult = false;
        }
        Console.Write("EnumOpenXmlConverterTest TestStronglyTypedGetEnumValueFromElement ");
        if (TestStronglyTypedGetEnumValueFromElement())
        {
            Console.WriteLine("passed.");
        }
        else
        {
            Console.WriteLine("failed.");
            testResult = false;
        }
        Console.Write("EnumOpenXmlConverterTest TestStronglyTypedGetEnumValueFromEnumValue ");
        if (TestStronglyTypedGetEnumValueFromEnumValue())
        {
            Console.WriteLine("passed.");
        }
        else
        {
            Console.WriteLine("failed.");
            testResult = false;
        }
        Console.Write("EnumOpenXmlConverterTest TestStronglyTypedConvert ");
        if (TestStronglyTypedConvert())
        {
            Console.WriteLine("passed.");
        }
        else
        {
            Console.WriteLine("failed.");
            testResult = false;
        }
        Console.Write("EnumOpenXmlConverterTest TestCreateEnumFromUInt16 ");
        if (TestCreateEnumFromUInt16())
        {
            Console.WriteLine("passed.");
        }
        else
        {
            Console.WriteLine("failed.");
            testResult = false;
        }
        Console.Write("EnumOpenXmlConverterTest TestCreateOpenXmlEnumValueFromModel ");
        if (TestCreateOpenXmlEnumValueFromModel())
        {
            Console.WriteLine("passed.");
        }
        else
        {
            Console.WriteLine("failed.");
            testResult = false;
        }
        Console.Write("EnumOpenXmlConverterTest TestCreateOpenXmlElementFromModel ");
        if (TestCreateOpenXmlElementFromModel())
        {
            Console.WriteLine("passed.");
        }
        else
        {
            Console.WriteLine("failed.");
            testResult = false;
        }
        return testResult;
    }

    /// <summary>
    ///   Tests round-trip conversion of a model enum value to an OpenXml enum value and back.
    /// </summary>
    /// <returns>True if the conversion is correct; otherwise, false.</returns>
    private static bool TestEnumValueConversion()
    {
        var modelValue = DMW.UnderlineKind.Dash;
        var openXmlEnumValue = EnumOpenXmlConverter.CreateOpenXmlEnumValue(modelValue, typeof(DX.EnumValue<DXW.UnderlineValues>));
        if (openXmlEnumValue is not DX.EnumValue<DXW.UnderlineValues> openXmlEnumValueCasted || openXmlEnumValueCasted.Value != DXW.UnderlineValues.Dash)
        {
            Console.WriteLine("Failed to convert Model Enum to OpenXml Enum");
            return false;
        }
        var convertedBackValue = EnumOpenXmlConverter.GetEnumValue((DX.EnumValue<DXW.UnderlineValues>)openXmlEnumValue, modelValue.GetType());
        if (convertedBackValue is not DMW.UnderlineKind convertedBackValueCasted || convertedBackValueCasted != modelValue)
        {
            Console.WriteLine("Failed to convert OpenXml Enum back to Model Enum");
            return false;
        }
        return true;
    }

    /// <summary>
    ///   Tests round-trip conversion of a model enum value to an OpenXml element and back.
    /// </summary>
    /// <returns>True if the conversion is correct; otherwise, false.</returns>
    private static bool TestEnumTypeConversion()
    {
        var modelValue = DMW.UnderlineKind.Dash;
        var openXmlEnumValue = EnumOpenXmlConverter.CreateOpenXmlElement(modelValue, typeof(DXW.Underline));
        if (openXmlEnumValue is not DXW.Underline openXmlEnumValueCasted || openXmlEnumValueCasted.Val?.Value != DXW.UnderlineValues.Dash)
        {
            Console.WriteLine("Failed to convert Model Enum to OpenXml Enum");
            return false;
        }
        var convertedBackValue = EnumOpenXmlConverter.GetEnumValue((DXW.Underline)openXmlEnumValue, modelValue.GetType());
        if (convertedBackValue is not DMW.UnderlineKind convertedBackValueCasted || convertedBackValueCasted != modelValue)
        {
            Console.WriteLine("Failed to convert OpenXml Enum back to Model Enum");
            return false;
        }
        return true;
    }

    /// <summary>
    ///   Tests strongly-typed extension method for getting a model enum value from an OpenXml element.
    /// </summary>
    /// <returns>True if the conversion is correct; otherwise, false.</returns>
    private static bool TestStronglyTypedGetEnumValueFromElement()
    {
        var underline = new DXW.Underline { Val = DXW.UnderlineValues.Wave };
        var converted = underline.GetEnumValue<DXW.UnderlineValues, DMW.UnderlineKind>();
        return converted == DMW.UnderlineKind.Wave;
    }

    /// <summary>
    ///   Tests strongly-typed extension method for getting a model enum value from an OpenXml EnumValue.
    /// </summary>
    /// <returns>True if the conversion is correct; otherwise, false.</returns>
    private static bool TestStronglyTypedGetEnumValueFromEnumValue()
    {
        var enumValue = new DX.EnumValue<DXW.UnderlineValues>(DXW.UnderlineValues.DotDash);
        var converted = enumValue.GetEnumValue<DXW.UnderlineValues, DMW.UnderlineKind>();
        return converted.HasValue && converted.Value == DMW.UnderlineKind.DotDash;
    }

    /// <summary>
    ///   Tests strongly-typed conversion from an OpenXml enum value to a model enum value.
    /// </summary>
    /// <returns>True if the conversion is correct; otherwise, false.</returns>
    private static bool TestStronglyTypedConvert()
    {
        var converted = EnumOpenXmlConverter.Convert<DMW.UnderlineKind, DXW.UnderlineValues>(DXW.UnderlineValues.DashDotDotHeavy);
        return converted.HasValue && converted.Value == DMW.UnderlineKind.DashDotDotHeavy;
    }

    /// <summary>
    ///   Tests conversion from a nullable ushort to a model enum value.
    /// </summary>
    /// <returns>True if the conversion is correct; otherwise, false.</returns>
    private static bool TestCreateEnumFromUInt16()
    {
        ushort? source = (ushort)DMW.UnderlineKind.DashLongHeavy;
        var converted = source.CreateEnum<DMW.UnderlineKind>();
        return converted.HasValue && converted.Value == DMW.UnderlineKind.DashLongHeavy;
    }

    /// <summary>
    ///   Tests creation of an OpenXml EnumValue from a model enum value.
    /// </summary>
    /// <returns>True if the conversion is correct; otherwise, false.</returns>
    private static bool TestCreateOpenXmlEnumValueFromModel()
    {
        DMW.UnderlineKind source = DMW.UnderlineKind.DottedHeavy;
        var enumValue = source.CreateOpenXmlEnumValue<DXW.UnderlineValues, DMW.UnderlineKind>();
        return enumValue != null && enumValue.Value == DXW.UnderlineValues.DottedHeavy;
    }

    /// <summary>
    ///   Tests creation of an OpenXml element from a model enum value.
    /// </summary>
    /// <returns>True if the conversion is correct; otherwise, false.</returns>
    private static bool TestCreateOpenXmlElementFromModel()
    {
        var modelValue = DMW.UnderlineKind.Thick;
        var element = modelValue.CreateOpenXmlElement<DXW.Underline, DXW.UnderlineValues, DMW.UnderlineKind>();
        return element.Val?.Value == DXW.UnderlineValues.Thick;
    }
}
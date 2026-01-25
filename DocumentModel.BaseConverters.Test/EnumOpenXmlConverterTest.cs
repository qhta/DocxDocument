

using System.Diagnostics;

using DocumentModel.OpenXml;

using DX = DocumentFormat.OpenXml;

using DXW = DocumentFormat.OpenXml.Wordprocessing;

using DMW = DocumentModel.Wordprocessing;

namespace DocumentModel.BaseConverters.Test;

public static class EnumOpenXmlConverterTest
{


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

    return testResult;
  }

  private static bool TestEnumValueConversion()
  {
    var modelValue = DMW.UnderlineKind.Dash;
    var openXmlEnumValue = EnumOpenXmlConverter.CreateOpenXmlEnumValue(modelValue, typeof(DX.EnumValue<DXW.UnderlineValues>));
    if (openXmlEnumValue is not DX.EnumValue<DXW.UnderlineValues> openXmlEnumValueCasted
        || openXmlEnumValueCasted.Value != DXW.UnderlineValues.Dash)
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

  private static bool TestEnumTypeConversion()
  {
    var modelValue = DMW.UnderlineKind.Dash;
    var openXmlEnumValue = EnumOpenXmlConverter.CreateOpenXmlElement(modelValue, typeof(DXW.Underline));
    if (openXmlEnumValue is not DXW.Underline openXmlEnumValueCasted
        || openXmlEnumValueCasted.Val?.Value != DXW.UnderlineValues.Dash)
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

}
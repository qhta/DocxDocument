using System.Reflection;
using DocumentFormat.OpenXml;

namespace DocumentModel.Impl;

public static class OpenXmlPartRootElementExtensions
{
  public static void SetPart(this OpenXmlPartRootElement rootElement, DocumentFormat.OpenXml.Packaging.OpenXmlPart part)
  {
    var propInfo = typeof(OpenXmlPartRootElement).GetProperty("OpenXmlPart", BindingFlags.Instance | BindingFlags.NonPublic);
    if (propInfo != null)
      propInfo.SetValue(rootElement, new object[] { part });
  }
}
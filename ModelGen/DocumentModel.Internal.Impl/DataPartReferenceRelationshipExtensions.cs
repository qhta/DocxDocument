using System.Reflection;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.Impl;

public static class DataPartReferenceRelationshipExtensions
{
  public static void SetDataPart(this DataPartReferenceRelationship rootElement, DocumentFormat.OpenXml.Packaging.DataPart part)
  {
    var propInfo = typeof(OpenXmlPartRootElement).GetProperty("DataPart", BindingFlags.Instance | BindingFlags.NonPublic);
    if (propInfo != null)
      propInfo.SetValue(rootElement, new object[] { part });
  }
}
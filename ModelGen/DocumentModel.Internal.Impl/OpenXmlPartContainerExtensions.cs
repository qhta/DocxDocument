using System;
using System.Reflection;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.Impl
{
  public static class OpenXmlPartContainerExtensions
  {
    public static void AddDataPartReferenceRelationship(this DocumentFormat.OpenXml.Packaging.OpenXmlPartContainer obj,
      DataPartReferenceRelationship relationship)
    {
      var methodInfo = typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPartContainer).GetMethod("AddDataPartReferenceRelationship", 
        BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{ typeof(DataPartReferenceRelationship)}, null);
      methodInfo.Invoke(obj, new object[] { relationship });
    }
  }
}

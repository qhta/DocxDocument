using System;
using System.Reflection;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.Impl
{
  public static class OpenXmlPPackageExtensions
  {
    public static void AddDataPartToList(this DocumentFormat.OpenXml.Packaging.OpenXmlPackage obj,
      DataPart dataPart)
    {
      var methodInfo = typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPackage).GetMethod("AddDataPartToList", 
        BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{ typeof(DataPart)}, null);
      methodInfo.Invoke(obj, new object[] { dataPart });
    }
  }
}

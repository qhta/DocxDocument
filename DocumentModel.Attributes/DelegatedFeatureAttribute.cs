// Decompiled with JetBrains decompiler
// Type: DocumentModel.Attributes.DelegatedFeatureAttribute
// Assembly: DocumentModel.Attributes, Version=2.18.0.0, Culture=neutral, PublicKeyToken=8fb06cb64d019a17
// MVID: A894C618-EA88-49A6-BB01-1ADD8EA78DE8
// Assembly location: C:\Users\qhta1\.nuget\packages\DocumentModel.Attributes\2.18.0\lib\netstandard2.0\DocumentModel.Attributes.dll
// XML documentation location: C:\Users\qhta1\.nuget\packages\DocumentModel.Attributes\2.18.0\lib\netstandard2.0\DocumentModel.Attributes.xml

using System;
using System.Diagnostics;


#nullable enable
namespace DocumentModel.Attributes
{
  [Conditional("OPENXMLGENERATOR")]
  [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
  public sealed class DelegatedFeatureAttribute : Attribute
  {
    public DelegatedFeatureAttribute(string name, Type? container = null)
    {
    }
  }
}

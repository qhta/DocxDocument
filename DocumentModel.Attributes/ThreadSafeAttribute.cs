// Decompiled with JetBrains decompiler
// Type: DocumentModel.Attributes.ThreadSafeAttribute
// Assembly: DocumentModel.Attributes, Version=2.18.0.0, Culture=neutral, PublicKeyToken=8fb06cb64d019a17
// MVID: A894C618-EA88-49A6-BB01-1ADD8EA78DE8
// Assembly location: C:\Users\qhta1\.nuget\packages\DocumentModel.Attributes\2.18.0\lib\netstandard2.0\DocumentModel.Attributes.dll
// XML documentation location: C:\Users\qhta1\.nuget\packages\DocumentModel.Attributes\2.18.0\lib\netstandard2.0\DocumentModel.Attributes.xml

using System;
using System.Diagnostics;

namespace DocumentModel.Attributes
{
  [Conditional("OPENXMLGENERATOR")]
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class ThreadSafeAttribute : Attribute
  {
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentModel.Attributes.EnumStringAttribute
// Assembly: DocumentModel.Attributes, Version=2.18.0.0, Culture=neutral, PublicKeyToken=8fb06cb64d019a17
// MVID: A894C618-EA88-49A6-BB01-1ADD8EA78DE8
// Assembly location: C:\Users\qhta1\.nuget\packages\DocumentModel.Attributes\2.18.0\lib\netstandard2.0\DocumentModel.Attributes.dll
// XML documentation location: C:\Users\qhta1\.nuget\packages\DocumentModel.Attributes\2.18.0\lib\netstandard2.0\DocumentModel.Attributes.xml

using System;


#nullable enable
namespace DocumentModel.Attributes
{
  /// <summary>
  /// Represents the custom attribute for fields in a generated enum.
  /// </summary>
  [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
  public sealed class EnumStringAttribute : Attribute
  {
    /// <summary>
    /// Initializes a new instance of the EnumStringAttribute class using
    /// the supplied text string.
    /// </summary>
    /// <param name="value">The text string.</param>
    public EnumStringAttribute(string value) => this.Value = value;

    /// <summary>Gets the text string in the custom attribute.</summary>
    public string Value { get; }
  }
}

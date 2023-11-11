// Decompiled with JetBrains decompiler
// Type: DocumentModel.Attributes.ChildElementInfoAttribute
// Assembly: DocumentModel.Attributes, Version=2.18.0.0, Culture=neutral, PublicKeyToken=8fb06cb64d019a17
// MVID: A894C618-EA88-49A6-BB01-1ADD8EA78DE8
// Assembly location: C:\Users\qhta1\.nuget\packages\DocumentModel.Attributes\2.18.0\lib\netstandard2.0\DocumentModel.Attributes.dll
// XML documentation location: C:\Users\qhta1\.nuget\packages\DocumentModel.Attributes\2.18.0\lib\netstandard2.0\DocumentModel.Attributes.xml

using System;
using System.ComponentModel;


#nullable enable
namespace DocumentModel.Attributes
{
  /// <summary>
  /// Defines the attribute which is used to decorate a class for type of the possible child elements.
  /// </summary>
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
  [Obsolete("This attribute is no longer used and will be removed in a later release")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public sealed class ChildElementInfoAttribute : Attribute
  {
    /// <summary>
    /// Initialize a new instance of ChildElementTypeAttribute.
    /// </summary>
    /// <param name="elementType">Specifies the type of the possible child element.</param>
    public ChildElementInfoAttribute(Type elementType)
      : this(elementType, FileFormatVersions.Office2007)
    {
    }

    /// <summary>
    /// Initialize a new instance of ChildElementTypeAttribute.
    /// </summary>
    /// <param name="elementType">Specifies the type of the possible child element.</param>
    /// <param name="availableInOfficeVersion">Specifies the office version where the child element is first available.</param>
    public ChildElementInfoAttribute(Type elementType, FileFormatVersions availableInOfficeVersion)
    {
      this.ElementType = elementType;
      this.AvailableInVersion = availableInOfficeVersion.AndLater();
    }

    /// <summary>Gets the type of the possible child element.</summary>
    public Type ElementType { get; }

    /// <summary>
    /// Gets the Office version(s) where the child element is available.
    /// </summary>
    public FileFormatVersions AvailableInVersion { get; }
  }
}

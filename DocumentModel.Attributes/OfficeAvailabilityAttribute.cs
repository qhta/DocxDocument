// Decompiled with JetBrains decompiler
// Type: DocumentModel.Attributes.OfficeAvailabilityAttribute
// Assembly: DocumentModel.Attributes, Version=2.18.0.0, Culture=neutral, PublicKeyToken=8fb06cb64d019a17
// MVID: A894C618-EA88-49A6-BB01-1ADD8EA78DE8
// Assembly location: C:\Users\qhta1\.nuget\packages\DocumentModel.Attributes\2.18.0\lib\netstandard2.0\DocumentModel.Attributes.dll
// XML documentation location: C:\Users\qhta1\.nuget\packages\DocumentModel.Attributes\2.18.0\lib\netstandard2.0\DocumentModel.Attributes.xml

using System;

namespace DocumentModel.Attributes
{
  /// <summary>
  /// Defines an OfficeAvailabilityAttribute class to indicate whether the property is available in a specific version of an Office application.
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field)]
  public sealed class OfficeAvailabilityAttribute : Attribute
  {
    /// <summary>Gets the Office version of the available property.</summary>
    public FileFormatVersions OfficeVersion { get; }

    /// <summary>
    /// Initializes a new instance of the OfficeAvailabilityAttribute class.
    /// </summary>
    /// <param name="officeVersion">The Office version where this class or property is available.
    /// If there is more than one version, use bitwise OR to specify multiple versions.</param>
    public OfficeAvailabilityAttribute(FileFormatVersions officeVersion) => this.OfficeVersion = officeVersion;
  }
}

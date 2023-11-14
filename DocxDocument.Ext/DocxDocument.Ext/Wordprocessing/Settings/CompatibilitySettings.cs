namespace DocumentModel.Wordprocessing;

/// <summary>
/// This is a collection of <see cref="CompatibilitySetting"/> items. 
/// It has no corresponding DocumentFormat.OpenXml.Wordprocessing class.
/// Instead items of DocumentFormat.OpenXml.Wordprocessing.CompatiblitySetting type 
/// are included directly in DocumentFormat.OpenXml.Wordprocessing.Compatibility element.
/// </summary>
public partial class CompatibilitySettings: NamedElementCollection<DXW.Compatibility, DXW.CompatibilitySetting, DMW.CompatibilitySetting>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public CompatibilitySettings(): base() { }

  public CompatibilitySettings(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public CompatibilitySettings(DXW.Compatibility openXmlElement): base(openXmlElement) { }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}

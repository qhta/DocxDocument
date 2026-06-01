namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the NonVisualGroupProperties Class.
/// </summary>
public class NonVisualGroupProperties: ModelElement
{
  /// <summary>
  ///   isLegacyGroup, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public bool? IsLegacyGroup { get; set; }
}

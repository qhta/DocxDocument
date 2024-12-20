namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BevelType Class.
/// </summary>
public class BevelType: ModelElement
{
  /// <summary>
  ///   w, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? Width { get; set; }

  /// <summary>
  ///   h, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? Height { get; set; }

  /// <summary>
  ///   prst, this property is only available in Office 2010 and later.
  /// </summary>
  public BevelPresetKind? PresetProfileType { get; set; }
}
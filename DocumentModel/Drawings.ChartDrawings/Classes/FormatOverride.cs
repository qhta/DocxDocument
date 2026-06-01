namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the FormatOverride Class.
/// </summary>
public class FormatOverride: ModelElement
{
  /// <summary>
  ///   idx, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public UInt32? Idx { get; set; }

  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}

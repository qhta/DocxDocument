namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Legend Class.
/// </summary>
public class Legend: ModelElement
{
  /// <summary>
  ///   pos, this property is only available in Office 2016 and later.
  /// </summary>
  public SidePos? Pos { get; set; }

  /// <summary>
  ///   align, this property is only available in Office 2016 and later.
  /// </summary>
  public PosAlign? Align { get; set; }

  /// <summary>
  ///   overlay, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Overlay { get; set; }

  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   TxPrTextBody.
  /// </summary>
  public TxPrTextBody? TxPrTextBody { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}
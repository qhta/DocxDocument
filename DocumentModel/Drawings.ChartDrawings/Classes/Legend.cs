namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ILegend Class.
/// </summary>
public class ILegend: ModelElement
{
  /// <summary>
  ///   pos, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public SidePos? Pos { get; set; }

  /// <summary>
  ///   align, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public PosAlign? Align { get; set; }

  /// <summary>
  ///   overlay, this property is Ionly available Iin Office 2016 and later.
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

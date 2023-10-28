namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the TextBodyProperties Class.
/// </summary>
public partial class TextBodyProperties
{
  
  /// <summary>
  ///   Rotation
  /// </summary>
  public Int32? Rotation { get; set; }
  
  
  /// <summary>
  ///   Paragraph Spacing
  /// </summary>
  public Boolean? UseParagraphSpacing { get; set; }
  
  
  /// <summary>
  ///   Left Inset
  /// </summary>
  public Int32? LeftInset { get; set; }
  
  
  /// <summary>
  ///   Top Inset
  /// </summary>
  public Int32? TopInset { get; set; }
  
  
  /// <summary>
  ///   Right Inset
  /// </summary>
  public Int32? RightInset { get; set; }
  
  
  /// <summary>
  ///   Bottom Inset
  /// </summary>
  public Int32? BottomInset { get; set; }
  
  
  /// <summary>
  ///   Number of Columns
  /// </summary>
  public Int32? ColumnCount { get; set; }
  
  
  /// <summary>
  ///   Space Between Columns
  /// </summary>
  public Int32? ColumnSpacing { get; set; }
  
  
  /// <summary>
  ///   Columns Right-To-Left
  /// </summary>
  public Boolean? RightToLeftColumns { get; set; }
  
  
  /// <summary>
  ///   From WordArt
  /// </summary>
  public Boolean? FromWordArt { get; set; }
  
  
  /// <summary>
  ///   Anchor Center
  /// </summary>
  public Boolean? AnchorCenter { get; set; }
  
  
  /// <summary>
  ///   Force Anti-Alias
  /// </summary>
  public Boolean? ForceAntiAlias { get; set; }
  
  
  /// <summary>
  ///   Text Upright
  /// </summary>
  public Boolean? UpRight { get; set; }
  
  
  /// <summary>
  ///   Compatible Line Spacing
  /// </summary>
  public Boolean? CompatibleLineSpacing { get; set; }
  
  
  /// <summary>
  ///   Preset Text Shape.
  /// </summary>
  public DMD.PresetTextWrap? PresetTextWrap { get; set; }
  
  public DMD.NoAutoFit? NoAutoFit { get; set; }
  
  public DMD.NormalAutoFit? NormalAutoFit { get; set; }
  
  public DMD.ShapeAutoFit? ShapeAutoFit { get; set; }
  
  public DMD.Scene3DType? Scene3DType { get; set; }
  
  public DMD.Shape3DType? Shape3DType { get; set; }
  
  public DMD.FlatText? FlatText { get; set; }
  
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}

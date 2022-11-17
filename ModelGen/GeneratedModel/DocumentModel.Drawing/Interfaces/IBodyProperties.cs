namespace DocumentModel.Drawing;

public interface IBodyProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public int? Rotation { get ; set; }

  public bool? UseParagraphSpacing { get ; set; }

  public TextVerticalOverflow? VerticalOverflow { get ; set; }

  public TextHorizontalOverflow? HorizontalOverflow { get ; set; }

  public TextVertical? Vertical { get ; set; }

  public DocumentModel.Drawing.TextWrapping? Wrap { get ; set; }

  public int? LeftInset { get ; set; }

  public int? TopInset { get ; set; }

  public int? RightInset { get ; set; }

  public int? BottomInset { get ; set; }

  public int? ColumnCount { get ; set; }

  public int? ColumnSpacing { get ; set; }

  public bool? RightToLeftColumns { get ; set; }

  public bool? FromWordArt { get ; set; }

  public TextAnchoringType? Anchor { get ; set; }

  public bool? AnchorCenter { get ; set; }

  public bool? ForceAntiAlias { get ; set; }

  public bool? UpRight { get ; set; }

  public bool? CompatibleLineSpacing { get ; set; }

  public IPresetTextWrap? PresetTextWrap { get ; set; }

}

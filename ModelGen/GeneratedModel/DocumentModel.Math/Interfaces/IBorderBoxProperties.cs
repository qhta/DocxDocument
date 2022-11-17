namespace DocumentModel.Math;

public interface IBorderBoxProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IHideTop? HideTop { get ; set; }

  public IHideBottom? HideBottom { get ; set; }

  public IHideLeft? HideLeft { get ; set; }

  public IHideRight? HideRight { get ; set; }

  public IStrikeHorizontal? StrikeHorizontal { get ; set; }

  public IStrikeVertical? StrikeVertical { get ; set; }

  public IStrikeBottomLeftToTopRight? StrikeBottomLeftToTopRight { get ; set; }

  public IStrikeTopLeftToBottomRight? StrikeTopLeftToBottomRight { get ; set; }

  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }

}

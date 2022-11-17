namespace DocumentModel.Drawing.Diagrams;

public interface IPropertySet // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? PresentationElementId { get ; set; }

  public string? PresentationName { get ; set; }

  public string? PresentationStyleLabel { get ; set; }

  public int? PresentationStyleIndex { get ; set; }

  public int? PresentationStyleCount { get ; set; }

  public string? LayoutTypeId { get ; set; }

  public string? LayoutCategoryId { get ; set; }

  public string? QuickStyleTypeId { get ; set; }

  public string? QuickStyleCategoryId { get ; set; }

  public string? ColorType { get ; set; }

  public string? ColorCategoryId { get ; set; }

  public bool? Coherent3D { get ; set; }

  public string? PlaceholderText { get ; set; }

  public bool? Placeholder { get ; set; }

  public int? Rotation { get ; set; }

  public bool? VerticalFlip { get ; set; }

  public bool? HorizontalFlip { get ; set; }

  public int? FixedWidthOverride { get ; set; }

  public int? FixedHeightOverride { get ; set; }

  public int? WidthScale { get ; set; }

  public int? HightScale { get ; set; }

  public bool? TextChanged { get ; set; }

  public int? FactorWidth { get ; set; }

  public int? FactorHeight { get ; set; }

  public int? NeighborOffsetWidth { get ; set; }

  public int? NeighborOffsetHeight { get ; set; }

  public int? RadiusScale { get ; set; }

  public int? IncludeAngleScale { get ; set; }

  public IPresentationLayoutVariables? PresentationLayoutVariables { get ; set; }

  public DocumentModel.Drawing.Diagrams.IStyle? Style { get ; set; }

}

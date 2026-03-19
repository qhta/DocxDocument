namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class PropertySet
{
  public bool ShouldSerializePresentationElementId() => !String.IsNullOrEmpty(PresentationElementId);
  public bool ShouldSerializePresentationName() => !String.IsNullOrEmpty(PresentationName);
  public bool ShouldSerializePresentationStyleLabel() => !String.IsNullOrEmpty(PresentationStyleLabel);
  public bool ShouldSerializePresentationStyleIndex() => PresentationStyleIndex is not null;
  public bool ShouldSerializePresentationStyleCount() => PresentationStyleCount is not null;
  public bool ShouldSerializeLayoutTypeId() => !String.IsNullOrEmpty(LayoutTypeId);
  public bool ShouldSerializeLayoutCategoryId() => !String.IsNullOrEmpty(LayoutCategoryId);
  public bool ShouldSerializeQuickStyleTypeId() => !String.IsNullOrEmpty(QuickStyleTypeId);
  public bool ShouldSerializeQuickStyleCategoryId() => !String.IsNullOrEmpty(QuickStyleCategoryId);
  public bool ShouldSerializeColorType() => !String.IsNullOrEmpty(ColorType);
  public bool ShouldSerializeColorCategoryId() => !String.IsNullOrEmpty(ColorCategoryId);
  public bool ShouldSerializeCoherent3D() => Coherent3D is not null;
  public bool ShouldSerializePlaceholderText() => !String.IsNullOrEmpty(PlaceholderText);
  public bool ShouldSerializePlaceholder() => Placeholder is not null;
  public bool ShouldSerializeRotation() => Rotation is not null;
  public bool ShouldSerializeVerticalFlip() => VerticalFlip is not null;
  public bool ShouldSerializeHorizontalFlip() => HorizontalFlip is not null;
  public bool ShouldSerializeFixedWidthOverride() => FixedWidthOverride is not null;
  public bool ShouldSerializeFixedHeightOverride() => FixedHeightOverride is not null;
  public bool ShouldSerializeWidthScale() => WidthScale is not null;
  public bool ShouldSerializeHightScale() => HightScale is not null;
  public bool ShouldSerializeTextChanged() => TextChanged is not null;
  public bool ShouldSerializeFactorWidth() => FactorWidth is not null;
  public bool ShouldSerializeFactorHeight() => FactorHeight is not null;
  public bool ShouldSerializeNeighborOffsetWidth() => NeighborOffsetWidth is not null;
  public bool ShouldSerializeNeighborOffsetHeight() => NeighborOffsetHeight is not null;
  public bool ShouldSerializeRadiusScale() => RadiusScale is not null;
  public bool ShouldSerializeIncludeAngleScale() => IncludeAngleScale is not null;
  public bool ShouldSerializePresentationLayoutVariables() => PresentationLayoutVariables is not null;
  public bool ShouldSerializeStyle() => Style is not null;
}

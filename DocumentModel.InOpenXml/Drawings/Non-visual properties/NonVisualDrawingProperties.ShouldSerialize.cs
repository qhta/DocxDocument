namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class NonVisualDrawingProperties<T>
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeDescription() => Description is not null;
  public bool ShouldSerializeHidden() => Hidden is not null;
  public bool ShouldSerializeTitle() => Title is not null;
  public bool ShouldSerializeHyperlinkOnClick() => HyperlinkOnClick is not null;
  public bool ShouldSerializeHyperlinkOnHover() => HyperlinkOnHover is not null;
  public bool ShouldSerializeNonVisualDrawingPropertiesExtensionList() => NonVisualDrawingPropertiesExtensionList is not null;
}

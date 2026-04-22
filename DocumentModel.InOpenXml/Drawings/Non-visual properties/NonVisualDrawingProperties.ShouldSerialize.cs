namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class NonVisualDrawingProperties<T> 
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeDescription() => !String.IsNullOrEmpty(Description);
  public bool ShouldSerializeHidden() => Hidden is not null;
  public bool ShouldSerializeTitle() => !String.IsNullOrEmpty(Title);
  public bool ShouldSerializeHyperlinkOnClick() => HyperlinkOnClick is not null;
  public bool ShouldSerializeHyperlinkOnHover() => HyperlinkOnHover is not null;
  public bool ShouldSerializeNonVisualDrawingPropertiesExtensionList() => NonVisualDrawingPropertiesExtensionList is not null;
}

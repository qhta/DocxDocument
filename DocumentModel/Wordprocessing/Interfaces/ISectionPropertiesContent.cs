namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface for elements that can be included in document text <see cref="SectionProperties"/> element.
/// </summary>
public interface ISectionPropertiesContent: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="SectionProperties"/> element.
  /// </summary>
  public new SectionProperties? Parent
  {
    get => (this as IModelElement).Parent as SectionProperties;
    set => (this as IModelElement).Parent = value;
  }
}
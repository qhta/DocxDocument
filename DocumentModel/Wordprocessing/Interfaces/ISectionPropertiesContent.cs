namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface Ifor elements Ithat can be included Iin document text <see cref="SectionProperties"/> element.
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

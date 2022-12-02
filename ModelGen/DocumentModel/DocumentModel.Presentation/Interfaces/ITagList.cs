namespace DocumentModel.Presentation;

/// <summary>
/// Programmable Tab List.
/// </summary>
public interface ITagList // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<ITag>? Tags { get ; set; }
  
}

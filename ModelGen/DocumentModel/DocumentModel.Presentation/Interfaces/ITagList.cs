namespace DocumentModel.Presentation;

/// <summary>
/// Programmable Tab List.
/// </summary>
public interface ITagList // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.ITag>? Tags { get ; set; }
  
}

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comments Collection.
/// </summary>
public interface IComments // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<IComment>? Comments { get ; set; }
  
}

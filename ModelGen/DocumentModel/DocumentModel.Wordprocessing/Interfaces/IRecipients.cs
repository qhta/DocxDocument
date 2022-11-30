namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines Recipients.
/// </summary>
public interface IRecipients // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IRecipientData>? RecipientDatas { get ; set; }
  
}

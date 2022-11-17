namespace DocumentModel.Bibliography;

public interface IAuthor // : DocumentFormat.OpenXml.Bibliography.NameOrCorporateType
{
  public INameList? NameList { get ; set; }
  
  public ICorporate? Corporate { get ; set; }
  
}

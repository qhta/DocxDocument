namespace DocumentModel.Bibliography;

public interface IPerformer // : DocumentFormat.OpenXml.Bibliography.NameOrCorporateType
{
  public INameList? NameList { get ; set; }

  public ICorporate? Corporate { get ; set; }

}

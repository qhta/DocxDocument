namespace DocumentModel.Drawing.Charts;

public interface IRichText // : DocumentFormat.OpenXml.Drawing.Charts.TextBodyType
{
  public IBodyProperties? BodyProperties { get ; set; }

  public IListStyle? ListStyle { get ; set; }

}

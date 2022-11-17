namespace DocumentModel.Drawing;

public interface ITableProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? RightToLeft { get ; set; }

  public bool? FirstRow { get ; set; }

  public bool? FirstColumn { get ; set; }

  public bool? LastRow { get ; set; }

  public bool? LastColumn { get ; set; }

  public bool? BandRow { get ; set; }

  public bool? BandColumn { get ; set; }

}

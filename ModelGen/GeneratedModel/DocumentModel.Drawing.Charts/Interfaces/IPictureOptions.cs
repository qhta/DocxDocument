namespace DocumentModel.Drawing.Charts;

public interface IPictureOptions // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IApplyToFront? ApplyToFront { get ; set; }

  public IApplyToSides? ApplyToSides { get ; set; }

  public IApplyToEnd? ApplyToEnd { get ; set; }

  public IPictureFormat? PictureFormat { get ; set; }

  public IPictureStackUnit? PictureStackUnit { get ; set; }

}

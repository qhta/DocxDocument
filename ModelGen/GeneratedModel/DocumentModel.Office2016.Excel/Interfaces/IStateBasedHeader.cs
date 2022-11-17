namespace DocumentModel.Office2016.Excel;

public interface IStateBasedHeader // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Uid { get ; set; }

  public FeatureType? Eft { get ; set; }

  public ExtFeatureType? Eftx { get ; set; }

  public SubFeatureType? Seft { get ; set; }

  public ExtSubFeatureType? Seftx { get ; set; }

  public IRefMap? RefMap { get ; set; }

}

namespace DocumentModel.Wordprocessing;

public interface ISectionProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IHexBinaryValue? RsidRPr { get ; set; }

  public IHexBinaryValue? RsidDel { get ; set; }

  public IHexBinaryValue? RsidR { get ; set; }

  public IHexBinaryValue? RsidSect { get ; set; }

}

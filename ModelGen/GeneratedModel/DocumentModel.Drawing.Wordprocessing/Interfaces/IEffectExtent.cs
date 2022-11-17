namespace DocumentModel.Drawing.Wordprocessing;

public interface IEffectExtent // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public long? LeftEdge { get ; set; }

  public long? TopEdge { get ; set; }

  public long? RightEdge { get ; set; }

  public long? BottomEdge { get ; set; }

}

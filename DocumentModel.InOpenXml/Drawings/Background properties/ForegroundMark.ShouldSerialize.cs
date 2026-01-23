namespace DocumentModel.Drawings;

public partial class ForegroundMark
{
  public bool ShouldSerializeFirstXCoordinate() => FirstXCoordinate is not null;
  public bool ShouldSerializeFirstYCoordinate() => FirstYCoordinate is not null;
  public bool ShouldSerializeSecondXCoordinate() => SecondXCoordinate is not null;
  public bool ShouldSerializeSecondYCoordinate() => SecondYCoordinate is not null;
}

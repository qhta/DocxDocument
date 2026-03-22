namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class Numbering
{
  public bool ShouldSerializeLastRevAbstractNumbering() => LastRevAbstractNumbering is not null;
  public bool ShouldSerializeAbstractNumberings() => !AbstractNumberings.IsEmpty();
  public bool ShouldSerializeNumberingInstances() => !NumberingInstances.IsEmpty();
  //public bool ShouldSerializeNumberingPictureBullets() => NumberingPictureBullets is not null;
}

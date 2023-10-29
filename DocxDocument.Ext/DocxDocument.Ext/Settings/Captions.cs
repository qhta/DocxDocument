namespace DocumentModel;
public partial class Captions
{
  public Captions(DXW.Captions captions)
  {
    _Captions = captions;
  }

  internal DXW.Captions _Captions { get; private set; }
}

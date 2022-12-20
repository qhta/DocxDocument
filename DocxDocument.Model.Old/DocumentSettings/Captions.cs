
namespace DocxDocument.Model;

public class Captions : DocxBasedCollection<DM.Caption, DM.ICaption, WD.Captions, WD.Caption>, ICaptions
{
  public Captions() : base(new WD.Captions())
  {
  }

  public Captions(WD.Captions wdCaptions) : base(wdCaptions)
  { }

}
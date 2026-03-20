
namespace DocumentModel.Interop.Core;

public interface ContactCard: InteropObject
{
  public void Close();

  public void Show
  (MsoContactCardStyle CardStyle, int RectangleLeft, int RectangleRight, int RectangleTop, int RectangleBottom,
    int HorizontalPosition, bool ShowWithDelay);
}

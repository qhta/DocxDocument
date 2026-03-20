
namespace DocumentModel.Interop.Core;

public partial interface ContactCard
{
  public void Close();
  public void Show
  (MsoContactCardStyle CardStyle, int RectangleLeft, int RectangleRight, int RectangleTop, int RectangleBottom,
    int HorizontalPosition, bool ShowWithDelay);
}

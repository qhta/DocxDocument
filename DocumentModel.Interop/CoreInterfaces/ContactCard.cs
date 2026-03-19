
namespace DocumentModel.Interop.Core;

public interface ContactCard: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  void Close();

  void Show
  (MsoContactCardStyle CardStyle, int RectangleLeft, int RectangleRight, int RectangleTop, int RectangleBottom,
    int HorizontalPosition, bool ShowWithDelay = false);
}
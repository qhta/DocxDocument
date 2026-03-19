
namespace DocumentModel.Interop.Core;

public interface CustomXMLValidationError: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  string Name { get; }
  CustomXMLNode Node { get; }
  string Text { get; }
  MsoCustomXMLValidationErrorType Type { get; }
  void Delete();
  int ErrorCode { get; }
}
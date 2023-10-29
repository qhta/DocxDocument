namespace DocumentModel;
public static class Utilities
{
  public static void ThrowError(Exception ex)
  {
    if (ex.InnerException != null)
      ThrowError(ex.InnerException);
    throw ex;
  }

}

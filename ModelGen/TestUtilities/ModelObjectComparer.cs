namespace TestUtilities;

public record Diff
{
  public string? ValuePath { get; set; }
  public object? ActualValue { get; set; }
  public object? ExpectedValue { get; set; }
  public string? Reason { get; set; }
}

public class DiffList: Collection<Diff>
{ 
  public void AddDiff(string? valuePath, object? actualValue, object? expectedValue)  =>
    Add(new Diff{ValuePath = valuePath, ActualValue = actualValue, ExpectedValue = expectedValue});

  public void AddDiff(string? valuePath, object? actualValue, object? expectedValue, string reason)  =>
    Add(new Diff{ValuePath = valuePath, ActualValue = actualValue, ExpectedValue = expectedValue, Reason = reason});

  public void Add(string? objName, string? propName, object? expectedValue, object? actualValue)
  {
    string? valuePath = null;
    if (objName !=null && propName != null)
      valuePath = objName+"."+propName;
    else
    if (objName !=null)
      valuePath = objName;
    else
    if (propName != null)
      valuePath = propName;
    Add(new Diff{ValuePath = valuePath, ActualValue = actualValue, ExpectedValue = expectedValue});
  }

}

public static class DeepComparer
{
  public static DiffList Diffs { get; set; } = new DiffList();

  public static bool CompareObjects(object? actualValue, object? expectedValue, string? propertyName = null)
  {
    Diffs.Clear();
    return CompareDeep(actualValue, expectedValue, propertyName);
  }

  private static bool CompareProperty(string propertyName, object? actualValue, object? expectedValue)
  {
    if (actualValue != null || expectedValue != null)
    {
      if (!object.Equals(actualValue, expectedValue))
      {
        if (!CompareDeep(actualValue, expectedValue, propertyName))
        {
          Diffs.AddDiff(propertyName, actualValue, expectedValue);
          return false;
        }
      }
    }
    return true;
  }

  private static bool CompareDeep(object? actualValue, object? expectedValue, string? propertyName = null)
  {
    var ok = true;
    if (actualValue != null && expectedValue != null)
    {
      var checkedType = actualValue.GetType();
      var expectedType = expectedValue.GetType();
      if (checkedType != expectedType)
      {
        Diffs.AddDiff(propertyName, actualValue.GetType(), expectedValue.GetType(), "types are different");
        return false;
      }
      if (actualValue is string s1 && expectedValue is string s2)
      {
        if (s1 != s2)
          return false;
        return true;
      }
      if (actualValue is byte[] b1 && expectedValue is byte[] b2)
      {
        if (b1.Length != b2.Length)
          return false;
        for (int i = 0; i < b1.Length; i++)
        {
          if (b1[i] != b2[i])
            return false;
        }
        return true;
      }
      else
      {
        var canCheck = false;
        var props = checkedType.GetProperties().Where(prop => prop.GetCustomAttribute<DataMemberAttribute>() != null).ToArray();
        if (props.Length > 0)
        {
          canCheck = true;
          foreach (var prop in props)
          {
            var val1 = prop.GetValue(actualValue);
            var val2 = prop.GetValue(expectedValue);
            var propName = String.Empty;
            if (!String.IsNullOrEmpty(propertyName))
              propName = propertyName + ".";
            propName += prop.Name;
            if (!CompareProperty(propName, val1, val2))
              return false;
          }
        }
        if (checkedType.IsEnumerable())
        {
          var enumIntf1 = actualValue as IEnumerable;
          var enumIntf2 = expectedValue as IEnumerable;
          if (enumIntf1 != null && enumIntf2 != null)
          {
            var enumerator1 = enumIntf1.GetEnumerator();
            var enumerator2 = enumIntf2.GetEnumerator();
            if (enumerator1 != null && enumerator2 != null)
            {
              canCheck = true;
              //enumerator1.Reset();
              //enumerator2.Reset();
              int n = 0;
              while (enumerator1.MoveNext() && enumerator2.MoveNext())
              {
                var item1 = enumerator1.Current;
                var item2 = enumerator2.Current;
                var propName = String.Empty;
                if (!String.IsNullOrEmpty(propertyName))
                  propName = propertyName + ".";
                propName += $"item[{n}]";

                if (!CompareProperty(propName, item1, item2))
                  ok = false;
              }
              if (enumerator1.MoveNext() != enumerator2.MoveNext())
              {
                Diffs.Add(propertyName, null, null, "unequal items count");
                ok = false;
              }
              return ok;
            }
          }
        }
        if (!canCheck)
        {
          return false;
        }
      }
    }
    return ok;
  }

}

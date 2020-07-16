# UniTryGetComponentExtensionMethods

TryGetComponent に関する拡張メソッド

## 使用例

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Start()
    {
        // 子オブジェクトからコンポーネントを取得
        if ( transform.TryGetComponentInChildren<BoxCollider>( out var collider1 ) )
        {
            Debug.Log( collider1 );
        }
        
        // 子オブジェクトからコンポーネントを取得
        if ( gameObject.TryGetComponentInChildren<BoxCollider>( out var collider2 ) )
        {
            Debug.Log( collider2 );
        }
        
        // 子オブジェクトからコンポーネントを取得（非アクティブも含む）
        if ( transform.TryGetComponentInChildren<BoxCollider>( out var collider3, true ) )
        {
            Debug.Log( collider3 );
        }
        
        // 子オブジェクトからコンポーネントを取得（非アクティブも含む）
        if ( gameObject.TryGetComponentInChildren<BoxCollider>( out var collider4, true ) )
        {
            Debug.Log( collider4 );
        }
        
        // 親オブジェクトからコンポーネントを取得
        if ( this.TryGetComponentInParent<BoxCollider>( out var collider5 ) )
        {
            Debug.Log( collider5 );
        }
        
        // 親オブジェクトからコンポーネントを取得
        if ( gameObject.TryGetComponentInParent<BoxCollider>( out var collider6 ) )
        {
            Debug.Log( collider6 );
        }
    }
}
```

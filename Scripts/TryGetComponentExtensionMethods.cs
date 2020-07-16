using UnityEngine;

namespace Kogane
{
	/// <summary>
	/// TryGetComponent に関する拡張メソッド
	/// </summary>
	public static class TryGetComponentExtensionMethods
	{
		/// <summary>
		/// 子オブジェクトからコンポーネントを取得します。見つかった場合は true を返します
		/// </summary>
		public static bool TryGetComponentInChildren<T>( this Component self, out T component ) where T : Component
		{
			component = self.GetComponentInChildren<T>();
			return component != null;
		}

		/// <summary>
		/// 子オブジェクトからコンポーネントを取得します。見つかった場合は true を返します
		/// </summary>
		public static bool TryGetComponentInChildren<T>( this GameObject self, out T component ) where T : Component
		{
			component = self.GetComponentInChildren<T>();
			return component != null;
		}

		/// <summary>
		/// 子オブジェクトからコンポーネントを取得します。見つかった場合は true を返します
		/// </summary>
		public static bool TryGetComponentInChildren<T>
		(
			this Component self,
			out  T         component,
			bool           includeInactive
		) where T : Component
		{
			component = self.GetComponentInChildren<T>( includeInactive );
			return component != null;
		}

		/// <summary>
		/// 子オブジェクトからコンポーネントを取得します。見つかった場合は true を返します
		/// </summary>
		public static bool TryGetComponentInChildren<T>
		(
			this GameObject self,
			out  T          component,
			bool            includeInactive
		) where T : Component
		{
			component = self.GetComponentInChildren<T>( includeInactive );
			return component != null;
		}

		/// <summary>
		/// 親オブジェクトからコンポーネントを取得します。見つかった場合は true を返します
		/// </summary>
		public static bool TryGetComponentInParent<T>( this Component self, out T component ) where T : Component
		{
			component = self.GetComponentInParent<T>();
			return component != null;
		}

		/// <summary>
		/// 親オブジェクトからコンポーネントを取得します。見つかった場合は true を返します
		/// </summary>
		public static bool TryGetComponentInParent<T>( this GameObject self, out T component ) where T : Component
		{
			component = self.GetComponentInParent<T>();
			return component != null;
		}
	}
}
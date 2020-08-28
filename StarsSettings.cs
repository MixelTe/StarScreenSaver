using Microsoft.Win32;
using System.Windows.Forms;

namespace StarScreen
{
	class StarsSettings
	{
		private static readonly string _KeyName = @"HKEY_CURRENT_USER\Software\MixelTe\ScreenSaverStars";
		private static readonly int D_DensitySize = 200;

		public static readonly int D_Density = 3;
		public static readonly int D_MaxDistance = 100;
		public static readonly bool D_CreateConections = true;
		public static readonly int D_MaxStarSize = 12;
		public static readonly int D_dStarSize = 6;
		public static readonly int D_MaxGrowSpeed = 10;
		public static readonly int D_dGrowSpeed = 5;
		public static readonly int D_MaxLifeTime = 200;
		public static readonly int D_dLifeTime = 149;

		public int MaxDistance = D_MaxDistance;
		public bool CreateConections = D_CreateConections;
		public int MaxStarSize = D_MaxStarSize;
		public int MaxGrowSpeed = D_MaxGrowSpeed;
		public int MaxLifeTime = D_MaxLifeTime;

		private int _Density = D_Density;

		public int GetDensity() => _Density;
		public int Density
		{
			get
			{
				return D_DensitySize * D_DensitySize / _Density;
			}
			set
			{
				_Density = value;
			}
		}
		public int MinStarSize
		{
			get
			{
				return MaxStarSize - D_dStarSize;
			}
		}
		public int MinGrowSpeed
		{
			get
			{
				return MaxGrowSpeed - D_dGrowSpeed;
			}
		}
		public int MinLifeTime
		{
			get
			{
				return MaxLifeTime = D_dLifeTime;
			}
		}

		public void Save()
		{
			Registry.SetValue(_KeyName, "MaxDistance", MaxDistance);
			Registry.SetValue(_KeyName, "Density", _Density);
			Registry.SetValue(_KeyName, "CreateConections", CreateConections ? 1 : 0);
			Registry.SetValue(_KeyName, "MaxStarSize", MaxStarSize);
			Registry.SetValue(_KeyName, "MaxGrowSpeed", MaxGrowSpeed);
			Registry.SetValue(_KeyName, "MaxLifeTime", MaxLifeTime);
		}
		//public static void LoadDefault()
		//{
		//	var maxDistance = Registry.GetValue(_KeyName, "MaxDistance", D_MaxDistance);
		//	var density = Registry.GetValue(_KeyName, "Density", D_Density);
		//	var createConections = Registry.GetValue(_KeyName, "CreateConections", D_CreateConections ? 1 : 0);
		//	var maxStarSize = Registry.GetValue(_KeyName, "MaxStarSize", D_MaxStarSize);
		//	var maxGrowSpeed = Registry.GetValue(_KeyName, "MaxGrowSpeed", D_MaxGrowSpeed);
		//	var maxLifeTime = Registry.GetValue(_KeyName, "MaxLifeTime", D_MaxLifeTime);

		//	if (maxDistance != null) D_MaxDistance = (int)maxDistance;
		//	if (density != null) D_Density = (int)density;
		//	if (createConections != null) D_CreateConections = (int)createConections == 1;
		//	if (maxStarSize != null) D_MaxStarSize = (int)maxStarSize;
		//	if (maxGrowSpeed != null) D_MaxGrowSpeed = (int)maxGrowSpeed;
		//	if (maxLifeTime != null) D_MaxLifeTime = (int)maxLifeTime;
		//}
		public void Load()
		{
			var maxDistance = Registry.GetValue(_KeyName, "MaxDistance", D_MaxDistance);
			var density = Registry.GetValue(_KeyName, "Density", D_Density);
			var createConections = Registry.GetValue(_KeyName, "CreateConections", D_CreateConections ? 1 : 0);
			var maxStarSize = Registry.GetValue(_KeyName, "MaxStarSize", D_MaxStarSize);
			var maxGrowSpeed = Registry.GetValue(_KeyName, "MaxGrowSpeed", D_MaxGrowSpeed);
			var maxLifeTime = Registry.GetValue(_KeyName, "MaxLifeTime", D_MaxLifeTime);

			if (maxDistance != null) MaxDistance = (int)maxDistance;
			if (density != null) Density = (int)density;
			if (createConections != null) CreateConections = (int)createConections == 1;
			if (maxStarSize != null) MaxStarSize = (int)maxStarSize;
			if (maxGrowSpeed != null) MaxGrowSpeed = (int)maxGrowSpeed;
			if (maxLifeTime != null) MaxLifeTime = (int)maxLifeTime;
		}

		public override string ToString()
		{
			return 
				"MaxDistance: " + MaxDistance +
				"\nCreateConections: " + CreateConections +
				"\nDensity: " + _Density +
				"\nDensityReal: " + Density +
				"\nMaxStarSize: " + MaxStarSize +
				"\nMinStarSize: " + MinStarSize +
				"\nMaxGrowSpeed: " + MaxGrowSpeed +
				"\nMinGrowSpeed: " + MinGrowSpeed +
				"\nMaxLifeTime: " + MaxLifeTime +
				"\nMinLifeTime: " + MinLifeTime
				;
		}
	}
}
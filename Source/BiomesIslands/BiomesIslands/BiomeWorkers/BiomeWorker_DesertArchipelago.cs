using BiomesIslands.Planet;
using RimWorld.Planet;

namespace BiomesIslands.BiomeWorkers
{
	public class BiomeWorker_DesertArchipelago : BiomeWorker_DesertIsland
	{
		protected override float GetIslandScore(Tile tile, int tileID, float islandPresence)
		{
			return base.GetIslandScore(tile, tileID, islandPresence) +
			       (WorldGenInfo_IslandPresence.IsArchipelago(islandPresence) ? 1.0F : -1.0F);
		}
	}
}
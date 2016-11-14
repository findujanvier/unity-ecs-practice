﻿using Entitas;
using UnityEngine;
public class CharacterInitializeSystem : ISetPool, IInitializeSystem {
	Pool _pool;

	public void SetPool (Pool pool)
	{
		_pool = pool;
	}

	public void Initialize ()
	{
		_pool.CreateEntity ()
			.IsCharacter(true)
			.AddName ("fdj")
			.AddPosition (10f, 0f, 10f)
			.AddBaseHitPoint (100)
			.AddHitPointRegenerationRate (Mathf.Clamp (.5f, 0f, 1f))
			.AddBaseManaPoint (100)
			.AddCurrentLevel (1)
			.AddCurrentExp (50)	
			.AddMoveSpeed (10f)
			.AddTurnSpeed (500f)		
			;
		;
	}
}

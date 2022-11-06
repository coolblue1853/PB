using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoreMountains.CorgiEngine
{
	/// <summary>
	/// An AIACtion used to have an AI kill itself
	/// </summary>
	[AddComponentMenu("Corgi Engine/Character/AI/Actions/AIActionSummonWolf")]
	public class AIActionSummonWolf : AIAction
	{
		public bool OnlyRunOnce = true;

		protected Character _character;
		protected MMHealthBar _health;
		protected Health health;
		protected bool _alreadyRan = false;

		public GameObject wolfS;

        /// <summary>
        /// On init we grab our Health
        /// </summary>
        /// 

        public override void Initialization()
		{
			base.Initialization();
			_character = this.gameObject.GetComponentInParent<Character>();
			_health = this.gameObject.GetComponent<MMHealthBar>();
			health = this.gameObject.GetComponent<Health>();
		}

		/// <summary>
		/// Kills the AI
		/// </summary>
		public override void PerformAction()
		{
			GameObject wolf = Instantiate(wolfS, new Vector2(this.transform.position.x, this.transform.position.y), this.transform.rotation);

			Destroy(this.gameObject);
		}

		/// <summary>
		/// On enter state we reset our flag
		/// </summary>
		public override void OnEnterState()
		{
			base.OnEnterState();
			_alreadyRan = false;
		}
	}
}
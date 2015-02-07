using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Animation2D : MonoBehaviour {

	private bool _isRunning;
	public bool IsRunning {
		get {return _isRunning; }
		set { 
			if(value && !_isRunning) {
				_timeSinceLastFrame = 0;
				_currentFrameIndex = 0;
            }
			_isRunning = value;

		}
	}

	public Sprite PauseSprite;

	public List<AnimationPart> frames;


	private float _timeSinceLastFrame;
	private int _currentFrameIndex = 0;

	private AnimationPart CurrentFrame  {
		get {
			return frames[_currentFrameIndex];
		}
	}

	// Use this for initialization
	void Start () {
		_timeSinceLastFrame = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if(!IsRunning){
			this.GetComponent<SpriteRenderer>().sprite = PauseSprite;
			return;
		}
	
		_timeSinceLastFrame += Time.deltaTime;

		if(_timeSinceLastFrame >= CurrentFrame.duration) {
			_timeSinceLastFrame = 0;
			_currentFrameIndex++;
			if(_currentFrameIndex == frames.Count) 
				_currentFrameIndex = 0;
		}

		this.GetComponent<SpriteRenderer>().sprite = CurrentFrame.texture;
	}
}

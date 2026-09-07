# Unity linear-maze EEG paradigm

Unity project used to generate a visuospatial audiovisual paradigm for an EEG experiment.

The original project was developed in Unity 2020.3.4f1 and has been recovered and tested using Unity 2020.3.49f1.

## Scenes

### LinearMaze

First-person navigation through three consecutive visual contexts separated by doors.

The instrument sequence was repeated three times:

1. Guitar → Marimba → Bongos
2. Guitar → Marimba → Bongos
3. Guitar → Cymbal → Bongos

Thus, during the third traversal, the instrument presented in the second spatial context changed from marimba to cymbal.

The Unity scene itself does not impose fixed traversal timing. Navigation is controlled manually using the first-person controller.

For the EEG experiment, participants did not navigate the Unity environment directly. They viewed a prerecorded video of the traversal. Therefore, stimulus timing was identical across participants, and the experimental video is the appropriate temporal reference for EEG event timing.

### Recognition test

Visual recognition screen displaying seven instruments:

- harp
- bongos
- alto saxophone
- cymbal
- guitar
- tuba
- marimba

Four of these instruments had appeared at some point during the preceding navigation paradigm:

- guitar
- marimba
- cymbal
- bongos

The recognition scene contains no auditory stimulation.

## Unity version

Original project:

- Unity 2020.3.4f1

Recovered/tested with:

- Unity 2020.3.49f1

## Repository contents

This repository contains the Unity scenes, project configuration, and original project-specific scripts.

Some third-party visual assets and the original audio files are intentionally not redistributed because their redistribution licences could not be verified. See `THIRD_PARTY_ASSETS.md`.

## Experimental timing

Exact audiovisual event timings should be derived from the prerecorded experimental video rather than from the Unity runtime, because traversal speed in Unity is manually controlled.


# Quantum

An FRC dashboard focused on simplicity, stability and performance.

## Philosophy

Typical FRC dashboards, such as [Shuffleboard](https://docs.wpilib.org/en/stable/dashboards/shuffleboard) are unmaintained and full of bloat that affect performance. This project aims to create a simple, stripped dashboard. By narrowing design and featureset, we can hopefully create a well-maintained, loved, high-performance dashboard that everyone can enjoy.

This does mean we remove highly enjoyed features such as data recording and graphing. Users looking for these features may want a more complex dashboard such as AdvantageScope.

## Project Goals

- [ ] Always On Top toggle
- [ ] Restore window size & position on launch
- [ ] Flexible Grid UI
- [ ] Tabular Data
- [ ] UI serialization and deserialization
  - [ ] Check if layout is possible (min/max checks)
- [ ] Widgets
  - [ ] Camera
    - [ ] Crosshair
    - [ ] Bandwidth Estimator
    - [ ] Resolution & FPS customization
  - [ ] Text
  - [ ] Boolean Box
- [ ] Application Settings
  - [ ] Dark/Light theme
  - [ ] Enable/disable analytics (crash reports will be mandatory during testing period)
  - [ ] Reset application (reset all layouts and settings)
  - [ ] Attempt to restore window size & position on launch
- [ ] NT4 connection
- [ ] Target ping stats
- [ ] "Simple" code generated layout
  - [ ] Investigate Eli's telemetry spec
  - [ ] Develop spec or support subset of Shuffleboard API
- Probably more, pending

## Control Submission Policy FAQ

- Is it a simple visualization widget (speed gauge, boolean box, slider, etc)?
  - Sure.
- Does it require external libraries such as `LiveCharts`?
  - Maybe, probably not.
- Does it require heavy logic?
  - No

## What we WON'T support

To keep scope minimal, we have decided to not support the following features.

- Graphing
- Data Recording
- Complex Controls (custom controls, plugins, etc).

## Building

Application targets `.NET 8.0`. Simply run `dotnet publish -c Release` to build a release binary. Binaries are located in `bin/Release`.

## Artifacts

Artifacts are provided via GitHub actions. All artifacts downloaded from GitHub actions are considered unstable.

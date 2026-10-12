# Project Progress - SAM_Mollier (2026-Q4)

## Q4 agent instructions rollout closeout - 2026-10-12

- SAM-BIM/SAM_Mollier#11 merged as `9b54f295d5af25ab824b6979e2d7dad458c29d81` (merge commit pinned to approved head `3778580b9e57a8ebd30d85e42698313c3472c189`; base `sow/2026-Q4` `2b99d895d97683e03be63a2ab2fabafa7e3c0f69`; validated content `3a8741346c149fc7c370dcdb38ff1d60d89ca630`). Owner-authorized 2026-10-12 after an independent review (`AGENT_ROLLOUT_REVIEW_2026-10-12.md`, local to the owner's workspace, not committed).
- Docs only: AGENTS.md, CLAUDE.md, plus the rollout record `documentation/Agent-Continuity-Rollout-Q4.md`. No product code, build, workflow, dependency pin or tool changed; this closeout is the only `PROJECT_PROGRESS.md` change.
- Validation: local documentation checks and commands are in `documentation/Agent-Continuity-Rollout-Q4.md` (`git diff --check`, file scope, UTF-8/LF/no BOM, import). Hosted checks at the approved head: build success (run 38257978242); spdx success (run 38257977779). Dependency selection: dependency clones in the build log: SAM @ sow/2026-Q4.
- Cleanup: remote docs/agent-instructions-rollout-q4 deleted with an expected-SHA lease on 3778580b9e57a8ebd30d85e42698313c3472c189 after confirming it is contained in sow/2026-Q4 and no open PR uses it as head or base; the local branch and its worktree are preserved (worktree in use). Other branches, worktrees and the frozen quarters were not touched.
- Remaining gaps: no agent-client behaviour or token benchmark has been run.
- Exact next step: Continue from the shared `AGENTS.md`. Open item carried from the pilots: verify on each installed agent client, in a fresh Q4 session, that it follows the instructions without loading the full progress history, and record the result.

## Icon migration closeout — 2026-10-11

- [SAM_Mollier#10](https://github.com/SAM-BIM/SAM_Mollier/pull/10) merged as `e52b9a033545007467118cacf8d174f40bd0b20f`; owner authorized merging after green/safe validation. Feature branch preserved.
- Completed frozen SAM#179 glyph/palette/badge migration; component GUIDs, APIs, namespaces, metadata and behavior preserved. Icon resources, manifests/generation kit, token assignments and PR validation record changed; no unrelated production refactor.
- Fresh local `Release` build PASS; source guard 28 token swaps / 0 non-icon C# changes (standard SPDX headers and additive resource properties excepted); 28 resource references / 0 errors. Final-head GitHub checks passed before merge. Available regression test results are recorded in `documentation/Icon-Migration-Validation-2026-10-11.md`; hosted Rhino smoke is not claimed as a fresh pass.
- Revit-family additional builds: 2025/2027 passed where applicable. OCCT native build and native integration cases were not required for resource-only changes; skips remain documented.
- Remaining: no known blocker for this merged icon PR. SAM_Building and separate local test/environment failures elsewhere remain tracked in the organisation audit; unrelated PR9 is not merged by this task. All network operations target SAM-BIM; historical external integration/attribution text is unchanged.
- Exact next step: owner visual review of merged icons in the installed host, then continue other work from current Q4. No installer/submodule repin is included in this closeout.


## Branch

`sow/2026-Q4` - bootstrapped 2026-10-06 from `master` `fc73fd69`. Frozen Q3 record: `sow/2026-Q3` @ `711876a8` (not modified).

## Last updated

2026-10-06 (Q4 icon-redesign migration).

## Current status

Q4 branch cut from `master` `fc73fd69`, which is the exact commit pinned in SAM_Deploy's frozen Q3 baseline (`v20261006.1`). Bootstrap added only internal docs (this file, `AGENTS.md`). No product source changed. No Q4 product work has started.

## Q4 priorities

Not yet set by the owner. Record them here at the first Q4 planning pass. Known carry-over work is listed below.

## Known carry-over work

- **SAM Grasshopper icon redesign - PR #8** (`feature/sam-gh-icon-redesign` @ `4eefde10`, open, base `sow/2026-Q3`, not merged). Analysed 2026-10-06: the branch carries only its own 5 icon-only commits (`698b42e`, `7af01a1`, `0340ed1`, `80da188`, `4eefde1`) on top of Q3 commit `5c336cdc`. Those commits are not reachable from `sow/2026-Q4` (Q4 is built on the promoted `master` line), so a plain retarget would list 8 commits. Replaying exactly those commits onto `sow/2026-Q4` @ `7e225a59` is conflict-free (verified commit-by-commit with `git merge-tree`; identical to the net-diff merge). Planned action: rebase-onto Q4 as a new branch + PR, then close this one; owner-approved controlled task, not yet executed. **Update:** migrated; replacement Q4 PR SAM_Mollier#10 (see the icon-redesign migration section); this old PR stays open for now.

## Repository-specific next steps

- Await Q4 planning. Open PRs for Q4 work against `sow/2026-Q4`.
- Follow the continuity convention in `AGENTS.md` for every PR and closeout.

## Decisions / assumptions

- Q4 base is `master` `fc73fd69`; the internal files were recovered from `sow/2026-Q3` into this branch only, never onto `master`.
- Q4 history intentionally does not contain the Q3 branch history (the maintained `master` is the promoted Q3 line, which is not a descendant of `sow/2026-Q3`); the frozen `sow/2026-Q3` branch is the permanent record.
- Historical Q2/Q3 content below is kept as evidence; its branch names, SHAs and next steps describe Q3 and are not current instructions.

## Validation

- Bootstrap verified 2026-10-06: `sow/2026-Q4` was created at exactly `fc73fd69` and the push was a normal (non-forced) branch creation.

## Issues / blockers

- None at bootstrap.

## Next step

- Owner to set Q4 priorities; then start the first Q4 task from this branch.

## Q4 operational cleanup (2026-10-06)

- Reviewed every active Q2/Q3 reference in this repository on `sow/2026-Q4` (workflow branch filters, dependency-branch resolution, `.gitmodules`/validation, docs). Historical Q2/Q3 mentions (feature documentation records, the frozen Q3 section below) are intentionally unchanged.
- Changed (`7e225a5`): removed the dead `$candidates += 'sow/2026-Q2'` fallback from the dependency-branch resolution in `.github/workflows/build.yml`. No dependency repository has a `sow/2026-Q2` branch, so the entry never matched and resolution already fell through to the default branch; behaviour is unchanged (PR head ref, current sow ref, then the dependency's default branch) and no per-quarter edit is needed.
- Checked, no action: the `github.repository_owner == 'SAM-BIM'` build guard (intentional; its comment names HoareLea only to explain why the guard exists), CODEOWNERS (SAM-BIM owners), and workflow secrets (no HoareLea-named secret). The local `upstream` (HoareLea) remote is preserved.
- Carry-over: **SAM Grasshopper icon redesign - PR #8** (`feature/sam-gh-icon-redesign` @ `4eefde10`, open, base `sow/2026-Q3`, not merged). Analysed 2026-10-06: the branch carries only its own 5 icon-only commits (`698b42e`, `7af01a1`, `0340ed1`, `80da188`, `4eefde1`) on top of Q3 commit `5c336cdc`. Those commits are not reachable from `sow/2026-Q4` (Q4 is built on the promoted `master` line), so a plain retarget would list 8 commits. Replaying exactly those commits onto `sow/2026-Q4` @ `7e225a59` is conflict-free (verified commit-by-commit with `git merge-tree`; identical to the net-diff merge). Planned action: rebase-onto Q4 as a new branch + PR, then close this one; owner-approved controlled task, not yet executed.
- Full cross-repository record, migration table and owner decisions: `SAM_Deploy:sow/2026-Q4` `PROJECT_PROGRESS.md`.

## Q4 icon-redesign migration (2026-10-06)

- Old PR: SAM-BIM/SAM_Mollier#8 (`feature/sam-gh-icon-redesign` @ `4eefde10`, base `sow/2026-Q3`) - **preserved, open, untouched**.
- New branch `feature/sam-gh-icon-redesign-q4` cut from `sow/2026-Q4` @ `81ae291d`; new PR **SAM-BIM/SAM_Mollier#10** (base `sow/2026-Q4`), feature head `87bfd371`. **Not merged.**
- Replayed (old -> new, `cherry-pick -x`; commit set taken from the GitHub PR metadata): `698b42e`->`70d2942`, `7af01a1`->`5ba648e`, `0340ed1`->`e77b5bb`, `80da188`->`19900aa`, `4eefde1`->`426314d`; replay-only tip `426314d3`; plus one new docs commit `87bfd37` pointing the PR record at the new PR. No Q3 history imported.
- Verified at the replay-only tip, before the record commit: result tree identical to the net-diff merge of the old feature onto Q4 (`c93bdb53a2`); same aggregate and per-commit `git patch-id`, file set (129 files), numstat and blobs as the old PR; no workflow/`.gitmodules`/`AGENTS.md`/`PROJECT_PROGRESS.md`/solution changes. The final PR head is not tree-identical to the old feature by design (extra documentation-only commit).
- Validation: `check_source.py origin/sow/2026-Q4` OK, `check_assemblies.py` OK, local build 0 errors, relevant tests green (see the PR body); PR CI `build` success, `spdx` success; mergeable: mergeable.
- Next: owner decides whether/when to close the old PR; merge remains the maintainer's call.

---

# Historical record - 2026-Q3 (frozen)

Source: last revision of the file on `sow/2026-Q3`, commit `5c336cd` (the file was removed from the Q3 tip by `711876a`; `sow/2026-Q3` tip is `711876a8`). The Q3 file was an unpopulated template ("Not updated yet"); no Q3 work was recorded in this repository's progress file.

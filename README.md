       # Ctx.Kernel

       ## Overview

       `Ctx.Kernel` is the core runtime implementation of the **Embodied Persona Architecture (EPA)**. It serves as the lightweight, high-performance `Ctx-Runtime` Orchestrator designed to be embedded within host applications.

       This project leverages the **Microsoft Semantic Kernel** SDK to manage a hub-and-spoke model of specialized AI agents. Its primary responsibility is to translate user requests into deterministic, auditable actions, ensuring system safety, reliability, and observability.

       ## Architecture

       This project follows the principles outlined in our strategic Pathfinder Reports:

       * **Hub-and-Spoke Model:** The `Ctx.Kernel` acts as the central "hub" or Orchestrator. It manages and delegates tasks to specialized "spoke" agents.
       * **Directive-Driven:** The Orchestrator's behavior is governed by a lean, performance-optimized set of **Persona Artifacts** (CDAs/CSPs and a CL).
       * **Observability:** All significant actions are logged via the Agent Observability Protocol (AOP) to ensure the system is transparent and auditable.
       * **Separation of Concerns:** This library is designed to be a self-contained AI augmentation that can be integrated into larger, existing applications with a clean API boundary.

       ## Getting Started

       This project contains the core orchestration logic. A corresponding `Ctx.Kernel.Tests` project is used for unit and integration testing.
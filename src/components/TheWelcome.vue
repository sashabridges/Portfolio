<script setup lang="ts">
import WelcomeItem from './WelcomeItem.vue'
import DocumentationIcon from './icons/IconDocumentation.vue'
import ToolingIcon from './icons/IconTooling.vue'
import EcosystemIcon from './icons/IconEcosystem.vue'
import CommunityIcon from './icons/IconCommunity.vue'
import SupportIcon from './icons/IconSupport.vue'
</script>

<template>
  <WelcomeItem>
    <template #icon>
      <DocumentationIcon />
    </template>
    <template #heading>Past Experience</template>

    Sasha got her programming career started in 2019 when she completed her edX bootcamp at the University of Kansas.
    She then started working with edX as a teaching assistant for the Data Analysis and Visualization course.
    A short time later, she started working as a software engineer at A.D. Banker & Company.
  </WelcomeItem>

  <WelcomeItem>
    <template #icon>
      <EcosystemIcon />
    </template>
    <template #heading>Work at A.D. Banker & Company</template>
    Starting in August of 2019, Sasha started working at A.D. Banker & Company and stayed there until
    March of 2024. There, she was an integral part of the development team. She worked with up to 9 other developers
    to create, maintain, and test a constantly expanding API as well as several in-house applications. 
    She created many processes,  such as Cross Browser Testing and Unit Testing for the organization's manager application. 
    Countless unique landing pages were created for clients with individual business needs.
    Applications were updated and thoroughly tested for major version updates such as PHP 7 to PHP 8.1.
    
  </WelcomeItem>

  <WelcomeItem>
    <template #icon>
      <ToolingIcon />
    </template>
    <template #heading>Now what?</template>

    After being laid off in March of 2024, Sasha is working hard to re-enter the world of programming.
    She is updating her portfolio with projects like this one!  She is also taking several Udemy courses
    about various topics like Go, Kotlin, and Drupal. 
    
    <br />
    Learning is fun, and there have been so many
    technological improvements in the last few years! She can't wait to get her hands dirty.
  </WelcomeItem>

  <WelcomeItem>
    <template #icon>
      <CommunityIcon />
    </template>
    <template #heading>Check out My Code</template>

    Visit 
    <a href="https://github.com/sashabridges/Portfolio" target="_blank" rel="noopener">Sasha's portfolio</a>.
  </WelcomeItem>

  <WelcomeItem>
    <template #icon>
      <SupportIcon />
    </template>
    <template #heading>Support Sasha</template>

    Support Sasha by 
    <a href="https://www.linkedin.com/in/sasha-bridges/" target="_blank" rel="noopener">connecting on LinkedIn</a>.
  </WelcomeItem>
</template>

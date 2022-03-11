<template>
  <el-aside :width="collapsed ? '65px' : '250px'">
    
    <el-menu
      class="el-menu-vertical-demo"
      @open="handleOpen"
      @close="handleClose"
      :collapse="collapsed"
    >
      <el-menu-item v-on:click="handleCollapsed">
        <el-icon><icon-menu /></el-icon>
        <span>{{ collapsedText }}</span>
      </el-menu-item>
    </el-menu>
    <el-menu
      :router="true"
      class="el-menu-vertical-demo"
      @open="handleOpen"
      @close="handleClose"
      :collapse="collapsed"
      default-active="0"
    >
      <template v-for="(rule, index) in $router.options.routes" :key="index">
        <el-menu-item :index="`${index}`" :route="rule">
          <el-icon><location /></el-icon>
          <span>{{ rule.name }}</span>
        </el-menu-item>
      </template>
    </el-menu>
  </el-aside>
</template>
<script lang="ts">
import { defineComponent, toRefs, ref, computed } from "vue"
import { Location, Menu as IconMenu } from '@element-plus/icons'

export default defineComponent({
  components: {
    Location,
    IconMenu,
  },
  name: "NavBar",
  props: {
    isCollapse: {
      type: Boolean,
      default: false
    }
  },
  setup(props) {
    let { isCollapse } = toRefs(props);
    let collapsed = ref(isCollapse.value);
    const collapsedText = computed (() => {
      return collapsed.value ? "Развернуть" : "Свернуть";
    });
    const handleCollapsed = () => {
      collapsed.value = !collapsed.value;

      console.log(`handleCollaps ${collapsed.value}`);
    }
    const handleOpen = () => {
      console.log("handleOpen");
    }
    const handleClose = () => {
      console.log("handleClose");
    }
    return {
      handleOpen,
      handleClose,
      handleCollapsed,
      collapsed,
      collapsedText,
    }
  },
});
</script>
